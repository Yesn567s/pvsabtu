using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Generator
    {
        public int id;
        public int resource_ref;
        public int production_rate = 1;
        public int level = 0;
        public string nama;
        bool active = false;

        public Generator(int id, int resource_reference) // 1. Clay 2. Iron 3. Wood 4. Crop
        {
            this.id = id;
            this.resource_ref = resource_reference;
            this.nama = SetNama(resource_reference, id);
        }

        public void Activate(bool active) // buat upgrade nanti :)
        {
            if (this.active)
            {
                this.active = false;
            }
            else
            {
                this.active = true;
            }
        }

        public string SetNama(int reference, int id) { // di kasi id biar identifikasinya gampang
            switch (reference)
            {
                case 1:
                    return "Clay pit " + id.ToString();
                case 2:
                    return "Iron Mine " + id.ToString();
                case 3:
                    return "WoodCutter " + id.ToString();
                case 4:
                    return "Cropland " + id.ToString();
                default:
                    break;
            }
            return "";
        }
    }
}
