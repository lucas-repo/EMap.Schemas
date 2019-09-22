using EMap.Xlink;

namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="OnlineResourceType", Namespace="http://www.opengis.net/ows")]
    public partial class OnlineResourceType1 {
        
        private typeType typeField;
        
        private bool typeFieldSpecified;
        
        private string hrefField;
        
        private string roleField;
        
        private string arcroleField;
        
        private string titleField;
        
        private showType showField;
        
        private bool showFieldSpecified;
        
        private actuateType actuateField;
        
        private bool actuateFieldSpecified;
        
        public OnlineResourceType1() {
            this.typeField = typeType.simple;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink")]
        public typeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink", DataType="anyURI")]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink", DataType="anyURI")]
        public string role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink", DataType="anyURI")]
        public string arcrole {
            get {
                return this.arcroleField;
            }
            set {
                this.arcroleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink")]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink")]
        public showType show {
            get {
                return this.showField;
            }
            set {
                this.showField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showSpecified {
            get {
                return this.showFieldSpecified;
            }
            set {
                this.showFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink")]
        public actuateType actuate {
            get {
                return this.actuateField;
            }
            set {
                this.actuateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actuateSpecified {
            get {
                return this.actuateFieldSpecified;
            }
            set {
                this.actuateFieldSpecified = value;
            }
        }
    }
}
