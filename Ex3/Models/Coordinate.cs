﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace Ex3.Models
{
    public class Coordinate
    {
        public Coordinate() { }
        public Coordinate(double lon, double lat)
        {
            this.Lon = lon;
            this.Lat = lat;
        }

        public double Lon { get; set; }
        public double Lat { get; set; }

        public void ToXml(XmlWriter writer)
        {
            writer.WriteStartElement("Coordinate");
            writer.WriteElementString("Lon", this.Lon.ToString());
            writer.WriteElementString("Lat", this.Lat.ToString());
            writer.WriteEndElement();
        }
    }
}