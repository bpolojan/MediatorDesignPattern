using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkerPositions
{
    internal class MarkerMediator
    {
        private List<Marker> markers = new List<Marker>();

        internal Marker CreateMarker()
        {
            var marker = new Marker();
            marker.SetMediator(this);
            this.markers.Add(marker);
            return marker;
        }

        public void Send(Point location, Marker marker)
        {
            this.markers.Where(m => m != marker).ToList().ForEach(m => m.ReceiveLocation(location));
        }
    }
}
