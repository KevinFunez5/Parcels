using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public int  Weight { get; set; }
    public int Length { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    private static List<Parcel> _box = new List<Parcel> {};

    public Parcel( int weight, int length, int height, int width)
    {
      Weight = weight;
      Length = length;
      Height = height;
      Width = width;
      _box.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _box;
    }

  }
}