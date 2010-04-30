using System;

namespace NSubstitute
{
    public class RaiseEventRoute : IRoute
    {
        private readonly IRouteParts _routeParts;

        public RaiseEventRoute(IRouteParts routeParts)
        {
            _routeParts = routeParts;
        }

        public object Handle(ICall call)
        {
            _routeParts.GetPart<RaiseEventHandler>().Handle(call);
            return _routeParts.GetPart<ReturnDefaultForCallHandler>().Handle(call);            
        }
    }
}