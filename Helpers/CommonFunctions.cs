using Authentication_Authorization_AddApiEndpoints.Dtos;
using System.Collections.ObjectModel;

namespace Authentication_Authorization_AddApiEndpoints.Helpers
{
    public static class CommonFunctions
    {
        public static List<TimeZoneDto> GetTimeZoneList()
        {
            List<TimeZoneDto> objTimeZoneList = new List<TimeZoneDto>();
            ReadOnlyCollection<TimeZoneInfo> tzi;
            tzi = TimeZoneInfo.GetSystemTimeZones();
            foreach (TimeZoneInfo timeZone in tzi)
            {
                TimeZoneDto objTimeZoneDto = new TimeZoneDto();
                objTimeZoneDto.Id = timeZone.Id;
                objTimeZoneDto.DisplayName = timeZone.DisplayName;
                objTimeZoneList.Add(objTimeZoneDto);
            }
            return objTimeZoneList;
        }
    }
}
