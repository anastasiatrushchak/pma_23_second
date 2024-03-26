using System;

namespace pattern3
{
    class BuyerHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Electronics")
            {
                return $"Buyer: I'll buy {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
