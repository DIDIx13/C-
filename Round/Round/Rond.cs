public class Rond
{
	// Attributs
	private double dblRayon;
		
	// Constructeurs
	
	// Constructeur par défaut
	public void CalculRond()
	{
        this.dblRayon = 10.00;
	}
	
	// Constructeurs spécifiques
	public void CalculRond(double rayonDeBase)
	{
        this.dblRayon = rayonDeBase;
        setRayon(rayonDeBase);  // le setter fera les tests
	}
	
	// Accesseurs
	public double getRayon()
	{
		return dblRayon;
	}
        
	public void setRayon(double rayon)
	{
		if (rayon > 0)
           this.dblRayon = rayon;
	}

    // Méthodes pour les calculs
    public double Diametre()
	{
		return 2 * dblRayon;
	}

	public double Perimetre()
	{
		return 2 * 3.1415 * dblRayon; // On utilise 3.1415 pour ne pas être dépendant de la library Math, moins précis mais plus indépandant.
	}
	
	public double Surface()
	{
        double Result = 3.1415 * dblRayon * dblRayon;
        return Result;
	}
    public override string ToString()
    {
        return base.ToString();
    }

}