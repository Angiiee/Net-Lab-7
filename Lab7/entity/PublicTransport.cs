using Lab7.action;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7.entity
{
    public abstract class PublicTransport : IVehicle
    {
        private TypeEntity type;
        private int routeNumber;
        private string ride;

        public TypeEntity Type { get => type; set => type = value; }
        public int RouteNumber { get => routeNumber; set => routeNumber = value; }
        public string Ride { get => ride; set => ride = value; }

        public enum TypeEntity { Tram, Bus, Trolleybus };

        protected PublicTransport()
        {
        }

        protected PublicTransport(TypeEntity type, int routeNumber, string ride)
        {
            Type = type;
            RouteNumber = routeNumber;
            Ride = ride;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool Equals(PublicTransport other)
        {
            return other != null &&
                   Type == other.Type &&
                   RouteNumber == other.RouteNumber &&
                   Ride == other.Ride;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type, RouteNumber, Ride);
        }

        public override string ToString()
        {
            return "I'm a public transport. ";
        }

        public virtual string GetInfo() => "Public Transport. I'm a " + Type + " and my number is " + RouteNumber + ". I do " + Ride;

        public string GoRide() => Ride;
    }
}
