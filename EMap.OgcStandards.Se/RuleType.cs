using EMap.OgcStandards.Ogc;

namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("Rule", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class RuleType {
        
        private string nameField;
        
        private DescriptionType descriptionField;
        
        private LegendGraphicType legendGraphicField;
        
        private object itemField;
        
        private double minScaleDenominatorField;
        
        private bool minScaleDenominatorFieldSpecified;
        
        private double maxScaleDenominatorField;
        
        private bool maxScaleDenominatorFieldSpecified;
        
        private SymbolizerType[] symbolizerField;
        
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
        public LegendGraphicType LegendGraphic {
            get {
                return this.legendGraphicField;
            }
            set {
                this.legendGraphicField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Filter", typeof(FilterType), Namespace="http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("ElseFilter", typeof(ElseFilterType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        public double MinScaleDenominator {
            get {
                return this.minScaleDenominatorField;
            }
            set {
                this.minScaleDenominatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinScaleDenominatorSpecified {
            get {
                return this.minScaleDenominatorFieldSpecified;
            }
            set {
                this.minScaleDenominatorFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public double MaxScaleDenominator {
            get {
                return this.maxScaleDenominatorField;
            }
            set {
                this.maxScaleDenominatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxScaleDenominatorSpecified {
            get {
                return this.maxScaleDenominatorFieldSpecified;
            }
            set {
                this.maxScaleDenominatorFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Symbolizer")]
        public SymbolizerType[] Symbolizer {
            get {
                return this.symbolizerField;
            }
            set {
                this.symbolizerField = value;
            }
        }
    }
}
