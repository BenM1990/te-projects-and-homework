using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class BuyoutAuction : Auction // Auction is our parent class - class that is being inherited from.
    {
        public BuyoutAuction(int buyoutPrice) : base()
        {
            _buyoutPrice = buyoutPrice;
        }

        //Buyout price - backing field
        private int _buyoutPrice;

        //Readonly get;
        public int BuyoutPrice 
        { 
            get
            {
                return _buyoutPrice;
            }
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            //If buyout price is not met bid as normal
            bool newHighBid = base.PlaceBid(offeredBid);

            if (newHighBid && offeredBid.BidAmount > this.BuyoutPrice)
            {
                Console.WriteLine("Buyout met by " + offeredBid.Bidder);
                base.EndAuction();
            }

            return newHighBid;
        }

        

    }
}
