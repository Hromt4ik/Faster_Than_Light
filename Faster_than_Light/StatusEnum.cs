using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Faster_than_Light.classes
{
    public static class StatusEnum
    {
        public enum MachineStatuses
        {
            [Description("На базе")]
            AtTheBase,
            [Description("Назначен водитель")]
            AssignedDriver,
            [Description("Ремонт")]
            Repair,
        }

        public enum PackageStatuses
        {
            [Description("Принята от клиента")]
            AcceptedFromClient,
            [Description("Отправлена на склад")]
            SentToWarehouse,
            [Description("Принята на складе")]
            AcceptedToWarehouse,
            [Description("Отправлена в город выдачи")]
            SentToDestinationCity,
            [Description("Принят в городе выдачи")]
            AcceptedDestinationCity,
            [Description("Отправлена в пункт выдачи")]
            SentIssuePoint,
            [Description("Принята в пункте выдачи")]
            AcceptedPointIssue,
            [Description("Утеряна")]
            Lost,
            [Description("Выдана")]
            Issued
        }

        public enum PackageType
        {
            [Description("Картон")]
            Paperboard,
            [Description("Полиэтилен")]
            Polyatilen,
            [Description("Пластик")]
            Plastic,
        }

        public static string GetDescription<T>(this T enumValue)
            where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                return null;

            var description = enumValue.ToString();
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo != null)
            {
                var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attrs != null && attrs.Length > 0)
                {
                    description = ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return description;
        }
    }
}
