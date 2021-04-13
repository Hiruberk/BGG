using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGGApp.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class items
    {

        private itemsItem[] itemField;

        private byte totalitemsField;

        private string termsofuseField;

        private string pubdateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public itemsItem[] item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte totalitems
        {
            get
            {
                return this.totalitemsField;
            }
            set
            {
                this.totalitemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string termsofuse
        {
            get
            {
                return this.termsofuseField;
            }
            set
            {
                this.termsofuseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pubdate
        {
            get
            {
                return this.pubdateField;
            }
            set
            {
                this.pubdateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class itemsItem
    {

        private itemsItemName nameField;

        private ushort yearpublishedField;

        private string imageField;

        private string thumbnailField;

        private itemsItemStatus statusField;

        private byte numplaysField;

        private string objecttypeField;

        private uint objectidField;

        private string subtypeField;

        private uint collidField;

        /// <remarks/>
        public itemsItemName name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ushort yearpublished
        {
            get
            {
                return this.yearpublishedField;
            }
            set
            {
                this.yearpublishedField = value;
            }
        }

        /// <remarks/>
        public string image
        {
            get
            {
                return this.imageField;
            }
            set
            {
                this.imageField = value;
            }
        }

        /// <remarks/>
        public string thumbnail
        {
            get
            {
                return this.thumbnailField;
            }
            set
            {
                this.thumbnailField = value;
            }
        }

        /// <remarks/>
        public itemsItemStatus status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public byte numplays
        {
            get
            {
                return this.numplaysField;
            }
            set
            {
                this.numplaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string objecttype
        {
            get
            {
                return this.objecttypeField;
            }
            set
            {
                this.objecttypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint objectid
        {
            get
            {
                return this.objectidField;
            }
            set
            {
                this.objectidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string subtype
        {
            get
            {
                return this.subtypeField;
            }
            set
            {
                this.subtypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint collid
        {
            get
            {
                return this.collidField;
            }
            set
            {
                this.collidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class itemsItemName
    {

        private byte sortindexField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sortindex
        {
            get
            {
                return this.sortindexField;
            }
            set
            {
                this.sortindexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class itemsItemStatus
    {

        private byte ownField;

        private byte prevownedField;

        private byte fortradeField;

        private byte wantField;

        private byte wanttoplayField;

        private byte wanttobuyField;

        private byte wishlistField;

        private byte preorderedField;

        private string lastmodifiedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte own
        {
            get
            {
                return this.ownField;
            }
            set
            {
                this.ownField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte prevowned
        {
            get
            {
                return this.prevownedField;
            }
            set
            {
                this.prevownedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fortrade
        {
            get
            {
                return this.fortradeField;
            }
            set
            {
                this.fortradeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte want
        {
            get
            {
                return this.wantField;
            }
            set
            {
                this.wantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte wanttoplay
        {
            get
            {
                return this.wanttoplayField;
            }
            set
            {
                this.wanttoplayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte wanttobuy
        {
            get
            {
                return this.wanttobuyField;
            }
            set
            {
                this.wanttobuyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte wishlist
        {
            get
            {
                return this.wishlistField;
            }
            set
            {
                this.wishlistField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte preordered
        {
            get
            {
                return this.preorderedField;
            }
            set
            {
                this.preorderedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lastmodified
        {
            get
            {
                return this.lastmodifiedField;
            }
            set
            {
                this.lastmodifiedField = value;
            }
        }
    }


}
