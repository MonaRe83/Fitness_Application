using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Athlete_RunningWild
{
    class Classinfo
    {
        private int updateID;
        private String warm_ups;
        private String location;
        private string activity;
        private decimal distance;
        private string datetime;


        public Classinfo(int up,String wa, String loc, string act, decimal dist, string dt)
        {
            // TODO: Complete member initialization
            this.updateID = up;
            this.warm_ups = wa;
            this.location = loc;
            this.activity = act;
            this.distance = dist;
            this.datetime = dt;
        }

        public int _up
        {
            get { return updateID; }
            set { updateID = value; }
        }

        public String wup
        {
            get { return warm_ups; }
            set { warm_ups = value; }
        }

        public String locat
        {
            get { return location; }
            set { location = value; }
        }
        
        public string actv
        {
            get { return activity; }
            set { activity = value; }
        }

        public decimal dis
        {
            get { return distance; }
            set { distance= value; }
        }

        public string dt
        {
            get { return datetime; }
            set { datetime = value; }
        }


    }
}
