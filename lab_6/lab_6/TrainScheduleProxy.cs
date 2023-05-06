using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class TrainScheduleProxy:ITrainSchedule
    {
        Dictionary<int, TrainInfo> trainCache = new Dictionary<int, TrainInfo>();
        TrainSchedule trainSchedule = new TrainSchedule();

        public  TrainInfo GetTrainInfo(int id)
        {
            if (!trainCache.TryGetValue(id, out TrainInfo train))
            {
                train = trainSchedule.GetTrainInfo(id);
                trainCache[id] = train;
            }

            return train;
        }
    }
}
