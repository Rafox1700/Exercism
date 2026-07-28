using System;
using System.Collections.Generic;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public override bool Equals(Object obj) 
        => obj is FacialFeatures face && this.EyeColor == face.EyeColor && this.PhiltrumWidth == face.PhiltrumWidth;

    public override int GetHashCode() 
        => HashCode.Combine(EyeColor, PhiltrumWidth);
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    
    public override bool Equals(Object obj)
        => obj is Identity i && this.Email == i.Email && this.FacialFeatures.Equals(i.FacialFeatures);

    public override int GetHashCode()
        => HashCode.Combine(Email, FacialFeatures);
}

public class Authenticator
{
    private static readonly FacialFeatures AdminFace = new FacialFeatures("green", 0.9m);

    private readonly HashSet<Identity> registeredIdentities = new HashSet<Identity>();
    
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
        => faceA.EyeColor == faceB.EyeColor && faceA.PhiltrumWidth == faceB.PhiltrumWidth;

    public bool IsAdmin(Identity identity) 
        => identity.Email == "admin@exerc.ism" && AreSameFace(identity.FacialFeatures, AdminFace);
    
    public bool Register(Identity identity) 
        => registeredIdentities.Add(identity);

    public bool IsRegistered(Identity identity) 
        => registeredIdentities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB)
        => ReferenceEquals(identityA, identityB);
}
