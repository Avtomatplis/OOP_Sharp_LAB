using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public class TrainStation:ITrainStation
    {
        /// <summary>
        /// Название станции
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Количество сотрудников
        /// </summary>
        public int EmployeesInStation { get; set; }
        /// <summary>
        /// Количество поездов
        /// </summary>
        public int NumberOfTrains { get; set; }
        /// <summary>
        ///   Директор станции
        /// </summary>
        public string DirectorName { get; set; } = "";

        static public int TrainStationCount { get; set; }

        public TrainStation(string Name, int EmployeesInStation, int NumberOfTrain, string DirectorName) 
        {
            this.Name = Name;
            this.EmployeesInStation = EmployeesInStation;
            this.NumberOfTrains = NumberOfTrain;
            this.DirectorName = DirectorName;
            TrainStationCount++;
        }

        public TrainStation() { TrainStationCount++; }

        public string GetInfo()
        {
          return ($"Name: {Name},\nEmployeesInStation: {EmployeesInStation},\nNumberOfTrains: {NumberOfTrains},\n" +
                $"DirectorName: {DirectorName}\n") ;
        }

       public ITrainStation Clone()
        {
            return new TrainStation(this.Name,this.EmployeesInStation,this.NumberOfTrains,this.DirectorName);
        }
    }
}
