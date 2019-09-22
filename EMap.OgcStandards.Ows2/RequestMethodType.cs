﻿namespace EMap.OgcStandards.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    public partial class RequestMethodType : OnlineResourceType {
        
        private DomainType[] constraintField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Constraint")]
        public DomainType[] Constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
    }
}