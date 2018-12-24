using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7.entity
{
    public class Tram : PublicTransport
    {
        public Tram()
        {
        }

        public override string GetInfo()
        {
            return base.GetInfo() + "And I'm awesome!";
        }

        public Tram(int routeNumber, string ride) : base(PublicTransport.TypeEntity.Tram, routeNumber, ride)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
