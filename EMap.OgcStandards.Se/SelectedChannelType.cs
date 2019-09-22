namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("RedChannel", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class SelectedChannelType {
        
        private string sourceChannelNameField;
        
        private ContrastEnhancementType contrastEnhancementField;
        
        /// <remarks/>
        public string SourceChannelName {
            get {
                return this.sourceChannelNameField;
            }
            set {
                this.sourceChannelNameField = value;
            }
        }
        
        /// <remarks/>
        public ContrastEnhancementType ContrastEnhancement {
            get {
                return this.contrastEnhancementField;
            }
            set {
                this.contrastEnhancementField = value;
            }
        }
    }
}
