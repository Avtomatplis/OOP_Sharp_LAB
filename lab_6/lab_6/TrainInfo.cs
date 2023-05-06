using System;

namespace lab_6
{
    public class TrainInfo
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public int PlatformNumber { get; set; }

        public override string ToString()
        {
            return $"Поезд номер {Id} выдвигается в {Destination} с платформы #{PlatformNumber}. Дата и время: {DepartureTime}";
        }

        public TrainInfo(int id, string destination, int platformNumber)
        {
            this.Id = id ;
            this.Destination = destination ;
            this.PlatformNumber = platformNumber ;
            this.DepartureTime = DateTime.Now ;
        }

    }
}
