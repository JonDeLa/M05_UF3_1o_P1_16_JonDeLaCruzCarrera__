using System;
using System.Collections.Generic;
public abstract class Store
{
    public string title;
    public string desc;
    public IMG_info icon;
    public IMG_info banner;
    public string trailer;
    public double price;
    public DateTime pDate;
    public int dSize;
    public Companny_info publiser;
    public List<Companny_info> developer = new List<Companny_info>();

    private IMG_info imgCompany;
}
public class audiovisual : Store
{
    public videos _video = null;
    public string _sTrack = null;
    public string format;
    public int bitrate;

    public float visualLength(int _sec)
    {
        return 0.0f;
    }
}

public class software: Store
{
    public List<int> games = new List<int>();
    public string tool;
    public string _DLCgame;
    public Games _game = null;
    public Tool _tool = null;
    public DLC _DLC = null;
    
}