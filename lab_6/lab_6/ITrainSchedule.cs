using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public interface ITrainSchedule
    {
        TrainInfo GetTrainInfo(int id);
    }
}
