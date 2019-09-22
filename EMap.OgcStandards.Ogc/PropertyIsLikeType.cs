namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsLike", Namespace="http://www.opengis.net/ogc", IsNullable=false)]
    public partial class PropertyIsLikeType : ComparisonOpsType {
        
        private PropertyNameType propertyNameField;
        
        private LiteralType literalField;
        
        private string wildCardField;
        
        private string singleCharField;
        
        private string escapeCharField;
        
        private bool matchCaseField;
        
        public PropertyIsLikeType() {
            this.matchCaseField = true;
        }
        
        /// <remarks/>
        public PropertyNameType PropertyName {
            get {
                return this.propertyNameField;
            }
            set {
                this.propertyNameField = value;
            }
        }
        
        /// <remarks/>
        public LiteralType Literal {
            get {
                return this.literalField;
            }
            set {
                this.literalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wildCard {
            get {
                return this.wildCardField;
            }
            set {
                this.wildCardField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string singleChar {
            get {
                return this.singleCharField;
            }
            set {
                this.singleCharField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string escapeChar {
            get {
                return this.escapeCharField;
            }
            set {
                this.escapeCharField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool matchCase {
            get {
                return this.matchCaseField;
            }
            set {
                this.matchCaseField = value;
            }
        }
    }
}
