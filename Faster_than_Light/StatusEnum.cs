using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faster_than_Light.classes
{
    public class StatusEnum
    {
        public enum MachineStatuses
        {
            AtTheBase, 
            AssignedDriver,
            Repair,

        }

        public enum ParcelStatuses
        {
            AcceptedFromClient,
            SentToWarehouse,
            AcceptedToWarehouse,
            SentToDestinationCity,
            AcceptedDestinationCity,
            SentIssuePoint,
            AcceptedPointIssue,
            Lost,
            Issued
        }
    }
}
