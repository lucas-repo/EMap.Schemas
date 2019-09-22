namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public enum SurfaceInterpolationType {
        
        /// <remarks/>
        none,
        
        /// <remarks/>
        planar,
        
        /// <remarks/>
        spherical,
        
        /// <remarks/>
        elliptical,
        
        /// <remarks/>
        conic,
        
        /// <remarks/>
        tin,
        
        /// <remarks/>
        parametricCurve,
        
        /// <remarks/>
        polynomialSpline,
        
        /// <remarks/>
        rationalSpline,
        
        /// <remarks/>
        triangulatedSpline,
    }
}
