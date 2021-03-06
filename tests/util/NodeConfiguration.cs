/*
This program is part of BruNet, a library for the creation of efficient overlay
networks.
Copyright (C) 2005  University of California

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
*/

using System;
using System.IO;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Xml;
using System.Xml.Serialization;

namespace Brunet
{

  public class NodeConfiguration 
  {
    protected ArrayList _transport_addresses;

    [System.Xml.Serialization.XmlArrayItem("TransportAddress",typeof(TransportAddressConfiguration))]
    public ArrayList TransportAddresses
    {
      get
      {
        return _transport_addresses;
      }
      set
      {
        _transport_addresses = value;
      }
    }

    public NodeConfiguration()
    {

    }

    public NodeConfiguration(ArrayList addresses)
    {
      _transport_addresses = addresses;
    }

  /*public static void Main(String[] args)
    {
      XmlSerializer serializer = new XmlSerializer(typeof(NodeConfiguration));
      TextWriter writer = new StreamWriter(args[0]);
      ArrayList tas = new ArrayList();
      tas.Add( new TransportAddressConfiguration("tcp","kupka.ee.ucla.edu","5000") );
      NodeConfiguration node_config = new NodeConfiguration();
      node_config.TransportAddresses = tas;
      serializer.Serialize( writer, node_config );
      writer.Close();      
      }*/

  }

}
