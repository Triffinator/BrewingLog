using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BrewingLog
{
    [Serializable]
    public class Beer
    {
        private ulong m_ID;
        private string m_style;
        private string m_brand;
        private string m_fermentables;
        private float m_ABV;
        private float m_OG;
        private float m_FG;

        private Date m_startDate;
        private Date m_finishingDate;

        private string m_hopsType;
        private string m_method;
        private string m_brewLength;
        private float m_litres;
        private string m_comments;

        public Beer()
        { }

        public Beer(ulong id)
        {
            ID = id;
        }

        public Beer(Beer other)
        {
            m_ID = other.ID;
            m_style = other.Style;
            m_brand = other.Brand;
            m_fermentables = other.Fermentables;
            m_ABV = other.ABV;
            m_OG = other.OG;

            if (other.FG != 0)
                m_FG = other.FG;

            m_startDate = other.StartDate;
            m_finishingDate = other.FinishingDate;

            m_hopsType = other.HopsType;
            m_method = other.Method;
            m_brewLength = other.BrewLength;
            m_litres = other.Litres;
            m_comments = other.Comments;
        }

        // Properties
        public ulong ID
        {
            get
            {
                return m_ID;
            }

            set
            {
                m_ID = value;
            }
        }

        public string Style
        {
            get
            {
                return m_style;
            }

            set
            {
                m_style = value;
            }
        }

        public string Brand
        {
            get
            {
                return m_brand;
            }

            set
            {
                m_brand = value;
            }
        }

        public string Fermentables
        {
            get
            {
                return m_fermentables;
            }

            set
            {
                m_fermentables = value;
            }
        }

        public float ABV
        {
            get
            {
                return m_ABV;
            }

            set
            {
                m_ABV = value;
            }
        }

        public float OG
        {
            get
            {
                return m_OG;
            }

            set
            {
                m_OG = value;
            }
        }

        public float FG
        {
            get
            {
                return m_FG;
            }

            set
            {
                m_FG = value;
            }
        }

        public Date StartDate
        {
            get
            {
                return m_startDate;
            }

            set
            {
                m_startDate = value;
            }
        }

        public Date FinishingDate
        {
            get
            {
                return m_finishingDate;
            }

            set
            {
                m_finishingDate = value;
            }
        }

        public string HopsType
        {
            get
            {
                return m_hopsType;
            }

            set
            {
                m_hopsType = value;
            }
        }

        public string Method
        {
            get
            {
                return m_method;
            }

            set
            {
                m_method = value;
            }
        }

        public string BrewLength
        {
            get
            {
                return m_brewLength;
            }

            set
            {
                m_brewLength = value;
            }
        }

        public float Litres
        {
            get
            {
                return m_litres;
            }

            set
            {
                m_litres = value;
            }
        }

        public string Comments
        {
            get
            {
                return m_comments;
            }

            set
            {
                m_comments = value;
            }
        }

        /**
         * @return: string  ID, brand and style, formatted by preset
         */
        public override string ToString()
        {
            return m_ID + "\n" + m_brand + "\t" + m_style;
        }
    }
}