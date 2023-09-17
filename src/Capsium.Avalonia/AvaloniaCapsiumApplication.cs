using Avalonia;
using Avalonia.Threading;

namespace Capsium.UI
{
    /// <summary>
    /// A base class for Avalonia UI Applications using the Capsium stack
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AvaloniaCapsiumApplication<T> : Application, IApp
        where T : class, ICapsiumDevice
    {
        public CancellationToken CancellationToken => throw new NotImplementedException();

        /// <summary>
        /// The ICapsiumDevice
        /// </summary>
        public static T Device => Resolver.Services.Get<ICapsiumDevice>() as T;

        /// <inheritdoc/>
        public Dictionary<string, string> Settings { get; internal set; } = new();

        protected AvaloniaCapsiumApplication()
        {
        }

        /// <summary>
        /// Invokes an action on the main (UI) thread
        /// </summary>
        /// <param name="action">The action to invoke</param>
        /// <param name="state">Optional state information to pass as a paramter to the Action</param>
        public void InvokeOnMainThread(Action<object?> action, object? state = null)
        {
            Dispatcher.UIThread.Post(() => action(state));
        }

        /// <inheritdoc/>
        public virtual Task OnError(Exception e)
        {
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public virtual Task OnShutdown()
        {
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public virtual void OnUpdate(Version newVersion, out bool approveUpdate)
        {
            approveUpdate = true;
        }

        /// <inheritdoc/>
        public virtual void OnUpdateComplete(Version oldVersion, out bool rollbackUpdate)
        {
            rollbackUpdate = false;
        }

        /// <inheritdoc/>
        public virtual Task CapsiumRun()
        {
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public virtual Task CapsiumInitialize()
        {
            return Task.CompletedTask;
        }

        Task IApp.Run()
        {
            return CapsiumRun();
        }

        Task IApp.Initialize()
        {
            return CapsiumInitialize();
        }

        protected void LoadCapsiumOS()
        {
            new Thread((o) =>
            {
                _ = CapsiumOS.Start(this, null);
            })
            {
                IsBackground = true
            }
            .Start();
        }
    }
}