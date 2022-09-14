using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ConcentID { get; set; }
        [StringLength(1000)]
        public string ConcentValue { get; set; }
        public DateTime ConcentDate { get; set; }
        public bool ContentStatus { get; set; }



        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }



        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }



        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
