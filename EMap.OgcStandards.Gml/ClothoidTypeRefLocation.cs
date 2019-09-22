namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/gml")]
    public partial class ClothoidTypeRefLocation {
        
        private AffinePlacementType affinePlacementField;
        
        /// <remarks/>
        public AffinePlacementType AffinePlacement {
            get {
                return this.affinePlacementField;
            }
            set {
                this.affinePlacementField = value;
            }
        }
    }
}
