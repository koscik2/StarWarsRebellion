using StarWarsRebellion.Resources;

namespace App1.Models
{
    public class XWing : Ship
    {
        public XWing()
        {
            Name = Strings.xwing;
            RedHealth = 0;
            GreyHealth = 2;
        }
    }
}
