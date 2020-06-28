﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CannedBytes.Midi.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CannedBytes.Midi.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified MidiBuffer is not marked as &apos;Done&apos;..
        /// </summary>
        public static string MidiBufferManager_BufferNotDone {
            get {
                return ResourceManager.GetString("MidiBufferManager_BufferNotDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified MidiBuffer is still queued by the Midi Port..
        /// </summary>
        public static string MidiBufferManager_BufferStillInQueue {
            get {
                return ResourceManager.GetString("MidiBufferManager_BufferStillInQueue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified MidiHeader does not belong to any MidiBuffer..
        /// </summary>
        public static string MidiBufferManager_HeaderNotAttached {
            get {
                return ResourceManager.GetString("MidiBufferManager_HeaderNotAttached", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified MidiHeader is not in sync with the MidiBuffer that owns it..
        /// </summary>
        public static string MidiBufferManager_HeaderOutOfSync {
            get {
                return ResourceManager.GetString("MidiBufferManager_HeaderOutOfSync", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MidiStream too long..
        /// </summary>
        public static string MidiBufferStream_PositionTooLong {
            get {
                return ResourceManager.GetString("MidiBufferStream_PositionTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot start the Midi In Port because the BufferManager has not been initialized. Call Initialize on the MidiInBufferManager..
        /// </summary>
        public static string MidiInPort_BufferManagerNotInitialzed {
            get {
                return ResourceManager.GetString("MidiInPort_BufferManagerNotInitialzed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Midi receiver can not be changed when the Midi In Port is started..
        /// </summary>
        public static string MidiInPort_CannotChangeReceiver {
            get {
                return ResourceManager.GetString("MidiInPort_CannotChangeReceiver", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MidiInPort is not connected to a MidiReceiver.
        /// </summary>
        public static string MidiInPort_NoReceiver {
            get {
                return ResourceManager.GetString("MidiInPort_NoReceiver", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Midi In Port is not open..
        /// </summary>
        public static string MidiInPort_PortNotOpen {
            get {
                return ResourceManager.GetString("MidiInPort_PortNotOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Midi callback receiver can not be changed when the Midi Out Stream Port is started..
        /// </summary>
        public static string MidiOutPort_CannotChangeCallback {
            get {
                return ResourceManager.GetString("MidiOutPort_CannotChangeCallback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Midi Out Port is not open..
        /// </summary>
        public static string MidiOutPort_PortNotOpen {
            get {
                return ResourceManager.GetString("MidiOutPort_PortNotOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid port status ({0})..
        /// </summary>
        public static string MidiPort_InvalidStatus {
            get {
                return ResourceManager.GetString("MidiPort_InvalidStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MidiPort of type {0} has been disposed..
        /// </summary>
        public static string MidiPort_ObjectDisposed {
            get {
                return ResourceManager.GetString("MidiPort_ObjectDisposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;count&apos; is larger than specified buffer length..
        /// </summary>
        public static string MidiStream_CountTooLarge {
            get {
                return ResourceManager.GetString("MidiStream_CountTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End of stream..
        /// </summary>
        public static string MidiStream_EndOfStream {
            get {
                return ResourceManager.GetString("MidiStream_EndOfStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not a readable stream..
        /// </summary>
        public static string MidiStream_NotReadable {
            get {
                return ResourceManager.GetString("MidiStream_NotReadable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot seek in stream..
        /// </summary>
        public static string MidiStream_NotSeekable {
            get {
                return ResourceManager.GetString("MidiStream_NotSeekable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not a writable stream..
        /// </summary>
        public static string MidiStream_NotWritable {
            get {
                return ResourceManager.GetString("MidiStream_NotWritable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot specify TimeFormatType.Smpte. Use the GetSmpteTime() method instead..
        /// </summary>
        public static string MidiStreamOutPort_InvalidTimeFormatType {
            get {
                return ResourceManager.GetString("MidiStreamOutPort_InvalidTimeFormatType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MidiStreamOutPort does not support short midi messages..
        /// </summary>
        public static string MidiStreamOutPort_NoShortMessage {
            get {
                return ResourceManager.GetString("MidiStreamOutPort_NoShortMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not a writable stream..
        /// </summary>
        public static string MidiStreamWriter_StreamNotWritable {
            get {
                return ResourceManager.GetString("MidiStreamWriter_StreamNotWritable", resourceCulture);
            }
        }
    }
}
