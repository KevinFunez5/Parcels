using System.Collections.Generic;
using System;

namespace Parcels.Models
{
  public class Parcel
  {
    public int  Weight { get; set; }
    public int Length { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Volume { get; set; }
    public int PriceToShip { get; set; } = 2;
    public int Total { get; set; }


    public Parcel( int weight, int length, int height, int width)
    {
      Weight = weight;
      Length = length;
      Height = height;
      Width = width;
    }

    public void GetVolume()
    {
      int volume = Length * Height * Width;
      Volume = volume;
    }

    public void GetCost()
    {
      int total = (Volume / Weight) * PriceToShip;
      Total = total;
    }

  }
}