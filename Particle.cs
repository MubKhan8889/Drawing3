class Particle
{
    // Variables
    private short xPos = 0;
    private short yPos = 0;

    private short xVelocity = 0;
    private short yVelocity = 0;

    // Base
    public Particle(int setMagnitude, int setVelocity)
    {
        SetRandomPosition(setMagnitude);
        SetRandomVelocity(setVelocity);
    }

    // Normal Functions
    public void SetRandomPosition(int setMagnitude)
    {
        TrueRandom tRandom = new TrueRandom();

        double posMagnitude = setMagnitude * tRandom.ReturnDouble();
        double setAngle = tRandom.ReturnDouble() * Math.PI * 2;

        xPos = (short)(Math.Sin(setAngle) * posMagnitude);
        yPos = (short)(Math.Cos(setAngle) * posMagnitude);

        xPos *= 4;
        yPos *= 4;
    }

    public void SetRandomVelocity(int setMagnitude)
    {
        TrueRandom tRandom = new TrueRandom();

        double posMagnitude = setMagnitude * tRandom.ReturnDouble();
        double setAngle = tRandom.ReturnDouble() * Math.PI * 2;

        xVelocity = (short)(Math.Sin(setAngle) * posMagnitude);
        yVelocity = (short)(Math.Cos(setAngle) * posMagnitude);

        xVelocity *= 4;
        yVelocity *= 4;
    }

    public void ParticleMove(double delta, Size formSize)
    {
        xPos += (short)(xVelocity * delta * 4);
        yPos += (short)(yVelocity * delta * 4);

        if (xPos > formSize.Width * 2)       xPos -= (short)(formSize.Width * 4);
        else if (xPos < formSize.Width * -2) xPos += (short)(formSize.Width * 4);

        if (yPos > formSize.Height * 2)       yPos -= (short)(formSize.Height * 4);
        else if (yPos < formSize.Height * -2) yPos += (short)(formSize.Height * 4);
    }

    public void ChangeVelocityBasedOnMousePos(double delta, Point mousePos, Size formSize, int strength, int radius)
    {
        int mousePosXCast = mousePos.X - (formSize.Width / 2);
        int mousePosYCast = mousePos.Y - (formSize.Height / 2);

        short xDiff = (short)(mousePosXCast - (xPos / 4));
        short yDiff = (short)(mousePosYCast - (yPos / 4));

        int particleMag = (int)Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
        
        if (particleMag > radius) return;

        double gravityEffect = (1 - (particleMag / radius)) * strength;

        xVelocity += (short)(xDiff * gravityEffect * delta * 4);
        yVelocity += (short)(yDiff * gravityEffect * delta * 4);
    }

    // Draw Functions
    public void DrawParticle(Graphics g, Size formSize)
    {
        Brush particleDraw = new SolidBrush(Color.White);

        float drawXPos = (xPos / 4) + (formSize.Width / 2);
        float drawYPos = (yPos / 4) + (formSize.Height / 2);

        g.FillEllipse(particleDraw, drawXPos, drawYPos, 3f, 3f);
    }
}