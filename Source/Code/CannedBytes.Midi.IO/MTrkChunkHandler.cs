﻿namespace CannedBytes.Media.IO.ChunkTypes.Midi
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using CannedBytes.Media.IO.SchemaAttributes;
    using CannedBytes.Midi.IO;
    using CannedBytes.Midi.Message;

    /// <summary>
    /// A custom chunk handler for the track chunk in a midi file.
    /// </summary>
    /// <remarks>It reads the midi track chunk data and fills a <see cref="MTrkChunk"/> instance.</remarks>
    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Trk", Justification = "Literal chunk name is used.")]
    [FileChunkHandler("MTrk")]
    public class MTrkChunkHandler : FileChunkHandler
    {
        /// <summary>
        /// A midi message factory for pooled short midi messages.
        /// </summary>
        private MidiMessageFactory midiMessageFactory = new MidiMessageFactory();

        /// <summary>
        /// Reads the midi track from the midi file.
        /// </summary>
        /// <param name="context">File context of the midi file being read. Must not be null.</param>
        /// <returns>Returns the custom chunk object containing the data that was read.</returns>
        [SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "Check is not recognized.")]
        public override object Read(ChunkFileContext context)
        {
            Check.IfArgumentNull(context, "context");

            var reader = context.CompositionContainer.GetService<FileChunkReader>();
            var stream = reader.CurrentStream;
            var chunk = new MTrkChunk();
            var events = new List<MidiFileEvent>();
            chunk.Events = events;

            var midiReader = new MidiFileStreamReader(stream);

            while (midiReader.ReadNextEvent())
            {
                MidiFileEvent midiEvent = null;

                switch (midiReader.EventType)
                {
                    case MidiFileEventType.Event:
                        midiEvent = this.CreateMidiEvent(midiReader.AbsoluteTime, midiReader.DeltaTime, midiReader.MidiEvent);
                        break;
                    case MidiFileEventType.SystemExclusive:
                        midiEvent = this.CreateSysExEvent(midiReader.AbsoluteTime, midiReader.DeltaTime, midiReader.Data);
                        break;
                    case MidiFileEventType.SystemExclusiveContinuation:
                        midiEvent = this.CreateSysExEvent(midiReader.AbsoluteTime, midiReader.DeltaTime, midiReader.Data);
                        break;
                    case MidiFileEventType.Meta:
                        midiEvent = this.CreateMetaEvent(midiReader.AbsoluteTime, midiReader.DeltaTime, midiReader.MetaEvent, midiReader.Data);
                        break;
                }

                if (midiEvent != null)
                {
                    events.Add(midiEvent);
                }
            }

            return chunk;
        }

        /// <summary>
        /// Creates a new midi event that represents a meta event.
        /// </summary>
        /// <param name="absoluteTime">The absolute-time of the event.</param>
        /// <param name="deltaTime">The delta-time of the event.</param>
        /// <param name="metaType">The type of meta event.</param>
        /// <param name="data">The data for the meta event.</param>
        /// <returns>Never returns null.</returns>
        private MidiFileEvent CreateMetaEvent(long absoluteTime, long deltaTime, byte metaType, byte[] data)
        {
            var midiEvent = new MidiFileEvent();

            midiEvent.AbsoluteTime = absoluteTime;
            midiEvent.DeltaTime = deltaTime;
            midiEvent.Message = this.midiMessageFactory.CreateMetaMessage((MidiMetaType)metaType, data);

            return midiEvent;
        }

        /// <summary>
        /// Creates a new midi event that represents a midi event.
        /// </summary>
        /// <param name="absoluteTime">The absolute-time of the event.</param>
        /// <param name="deltaTime">The delta-time of the event.</param>
        /// <param name="midiMsg">The midi event data.</param>
        /// <returns>Never returns null.</returns>
        private MidiFileEvent CreateMidiEvent(long absoluteTime, long deltaTime, int midiMsg)
        {
            var midiEvent = new MidiFileEvent();

            midiEvent.AbsoluteTime = absoluteTime;
            midiEvent.DeltaTime = deltaTime;
            midiEvent.Message = this.midiMessageFactory.CreateShortMessage(midiMsg);

            return midiEvent;
        }

        /// <summary>
        /// Creates a new midi event that represents a system exclusive event.
        /// </summary>
        /// <param name="absoluteTime">The absolute-time of the event.</param>
        /// <param name="deltaTime">The delta-time of the event.</param>
        /// <param name="data">The data for the sysex event.</param>
        /// <returns>Never returns null.</returns>
        private MidiFileEvent CreateSysExEvent(long absoluteTime, long deltaTime, byte[] data)
        {
            var midiEvent = new MidiFileEvent();

            midiEvent.AbsoluteTime = absoluteTime;
            midiEvent.DeltaTime = deltaTime;
            midiEvent.Message = this.midiMessageFactory.CreateSysExMessage(data);

            return midiEvent;
        }

        /// <summary>
        /// Not implemented yet.
        /// </summary>
        /// <param name="context">Unused.</param>
        /// <param name="instance">Unused.</param>
        public override void Write(ChunkFileContext context, object instance)
        {
            throw new System.NotImplementedException();
        }
    }
}