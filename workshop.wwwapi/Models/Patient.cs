using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace workshop.wwwapi.Models
{
    //TODO: decorate class/columns accordingly    
    public class Patient
    {        
        public int Id { get; set; }        
        public string FullName { get; set; }
    }
}
