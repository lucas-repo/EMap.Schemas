namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public enum SequenceRuleNames {
        
        /// <remarks/>
        Linear,
        
        /// <remarks/>
        Boustrophedonic,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Cantor-diagonal")]
        Cantordiagonal,
        
        /// <remarks/>
        Spiral,
        
        /// <remarks/>
        Morton,
        
        /// <remarks/>
        Hilbert,
    }
}
