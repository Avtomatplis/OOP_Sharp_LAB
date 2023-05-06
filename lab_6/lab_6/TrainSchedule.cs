using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace lab_6
{
    public class TrainSchedule:ITrainSchedule
    {
        private readonly List<TrainInfo> _trains;

        public TrainSchedule()
        {
            string json = File.ReadAllText("trainSchedule.json");
            _trains = JsonConvert.DeserializeObject<List<TrainInfo>>(json);
        }

        public TrainInfo GetTrainInfo(int id)
        {
            return _trains.FirstOrDefault(t => t.Id == id);
        }
    }
}
