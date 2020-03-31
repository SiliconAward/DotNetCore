using SiliconAward.Infrastructure.Base;

namespace SiliconAward.DataAccess.Entities
{
    public class CustomLog:BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string LogType { get; set; }
        public string Message1 { get; set; }
        public string Message2 { get; set; }
      //  public string Message3 { get; set; }
      //  public string Message4 { get; set; }
     //   public string Message5 { get; set; }

    }
}
