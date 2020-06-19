using System;
using UnitsNet;
using UnitsNet.Units;

namespace AvgSpeed
{

    public interface ITrack
    {
        Length Distance { get;  }
        string Name { get; }
        string Description { get;  }
    }


    public interface ISpeedSensor
    {
        (Speed speed, DateTime sampletime) CurrentSpeed { get; }
    }

    public struct Preferences
    {
        public SpeedUnit PreferredSpeedUnit;
        public LengthUnit PreferredLengthUnit;        
    }

    public class Speedometer
    {
        private Preferences _preferences;

        public Speedometer(ISpeedSensor speedSensor, Preferences preferences)
        {
            _preferences = preferences;
        }

        public Speed AverageSpeed(Duration duration, ITrack track)
        {            
            if (track == null)
            {
                throw new ArgumentNullException(nameof(track));
            }
            var distance = track.Distance;
            if (duration.Value <= 0)
            {
                throw new ArgumentException(nameof(duration));
            }
            if (distance.Value <= 0)
            {
                throw new ArgumentException(nameof(distance));
            }
            return (distance / duration).ToUnit(_preferences.PreferredSpeedUnit);
        }
        
    }
}
