using System;

namespace ChainOfResponsibility
{
    public abstract class RequestPermissionResponsible
    {
        private EventHandler<RequestPermissionArgs> requestPermissionHandler;

        public RequestPermissionResponsible()
        {
            requestPermissionHandler += Approve;
        }

        protected abstract void Approve(object sender, RequestPermissionArgs args);

        public RequestPermissionResponsible NextResponsible { get; set; }

        public void RequestPermission(RequestPermissionArgs args)
        {
            requestPermissionHandler(this, args);
        }
    }
}
