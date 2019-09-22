namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureTypeStyle", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class FeatureTypeStyleType {
        
        private string nameField;
        
        private DescriptionType descriptionField;
        
        private System.Xml.XmlQualifiedName featureTypeNameField;
        
        private string[] semanticTypeIdentifierField;
        
        private object[] itemsField;
        
        private VersionType versionField;
        
        private bool versionFieldSpecified;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public DescriptionType Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public System.Xml.XmlQualifiedName FeatureTypeName {
            get {
                return this.featureTypeNameField;
            }
            set {
                this.featureTypeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SemanticTypeIdentifier")]
        public string[] SemanticTypeIdentifier {
            get {
                return this.semanticTypeIdentifierField;
            }
            set {
                this.semanticTypeIdentifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OnlineResource", typeof(OnlineResourceType))]
        [System.Xml.Serialization.XmlElementAttribute("Rule", typeof(RuleType))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VersionType version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool versionSpecified {
            get {
                return this.versionFieldSpecified;
            }
            set {
                this.versionFieldSpecified = value;
            }
        }
    }
}
