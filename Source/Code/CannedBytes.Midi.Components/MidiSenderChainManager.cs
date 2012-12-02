using System;
using System.Collections.Generic;

namespace CannedBytes.Midi.Components
{
    /// <summary>
    /// The MidiSenderChainManager class manages building a chain of sender components.
    /// </summary>
    /// <typeparam name="T">The common interface to all sender components.</typeparam>
    public class MidiSenderChainManager<T> : DisposableBase
        where T : class
    {
        /// <summary>
        /// Constructs the manager with the specified <paramref name="sender"/>.
        /// </summary>
        /// <param name="sender">A sender component. Must not be null.</param>
        public MidiSenderChainManager(T sender)
        {
            //Throw.IfArgumentNull(sender, "sender");

            _sender = sender;
        }

        /// <summary>
        /// Gets the current chain component.
        /// </summary>
        /// <remarks>Can return null if the component does not implement the
        /// <see cref="IMidiSenderChain&lt;T&gt;"/> interface.</remarks>
        public IChainOf<T> CurrentChain
        {
            get { return _sender as IChainOf<T>; }
        }

        private T _sender;

        /// <summary>
        /// Gets the current (last) sender component.
        /// </summary>
        public T Sender
        {
            get
            {
                return _sender;
            }
            private set
            {
                ((IChainOf<T>)value).Next = _sender;
                _sender = value;
            }
        }

        /// <summary>
        /// Adds the <paramref name="sender"/> component to the chain.
        /// </summary>
        /// <param name="sender">A sender chain component.</param>
        /// <remarks>The method throws an exception when the <paramref name="sender"/>
        /// does not implement the <see cref="IMidiSenderChain&lt;T&gt;"/> interface.</remarks>
        public virtual void Add(T sender)
        {
            ThrowIfDisposed();
            //Throw.IfArgumentNull(sender, "sender");
            //Throw.IfArgumentNotOfType<IMidiSenderChain<T>>(sender, "sender");

            Sender = sender;
        }

        /// <summary>
        /// Initializes the sender chain components that implement the <see cref="IInitializeByMidiPort"/>
        /// interface with the specified Midi <paramref name="port"/>.
        /// </summary>
        /// <param name="port">A Midi Port. Must not be null.</param>
        public virtual void InitializeByMidiPort(IMidiPort port)
        {
            //Throw.IfArgumentNull(port, "port");

            foreach (var sender in Senders)
            {
                IInitializeByMidiPort init = sender as IInitializeByMidiPort;

                if (init != null)
                {
                    init.Initialize(port);
                }
            }
        }

        /// <summary>
        /// Gets an enumerable object that enumerate the Senders T.
        /// </summary>
        public IEnumerable<T> Senders
        {
            get
            {
                T sender = Sender;

                while (sender != null)
                {
                    yield return sender;

                    IChainOf<T> chain = sender as IChainOf<T>;

                    if (chain != null)
                    {
                        sender = chain.Next;
                    }
                    else
                    {
                        sender = default(T);
                    }
                }
            }
        }

        /// <summary>
        /// Disposes all components in the chain.
        /// </summary>
        /// <param name="disposing">True when called from the <see cref="Dispose"/> method,
        /// false when called from the Finalizer.</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (!IsDisposed)
                {
                    if (disposing)
                    {
                        foreach (var sender in Senders)
                        {
                            IDisposable disposable = sender as IDisposable;

                            if (disposable != null)
                            {
                                disposable.Dispose();
                            }
                        }

                        _sender = null;
                    }
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }
    }
}