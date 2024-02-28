﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Pr{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("\nLab 3");
      
      Console.WriteLine("Choose task: ");
      int s = Convert.ToInt32(Console.ReadLine());

  switch(s){
    case 1: { task1();  break;}
   // case 2: { task2();  break;}
   // case 3: { task3();  break;}
  }
      
    }

static void task1()
{
    Console.WriteLine("\nTask2");
    //List<Place> a= new List<Place>();

    int [] n=new int[4];
    string [] s=new string[6];

    Console.Write("Place id: ");
    for(int i = 0;i<2;i++)
    {
      n[i]= Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Place location: ");
    for(int i = 0;i<2;i++)
    {
      s[i]= Convert.ToString(Console.ReadLine());
    }

    Console.Write("Region size(big/medium/small): ");
    for(int i = 2;i<4;i++)
    {
      s[i]= Convert.ToString(Console.ReadLine());
    }
    Console.Write("Town nation(ukr/usa/uk): ");
    for(int i = 4;i<6;i++)
    {
      s[i]= Convert.ToString(Console.ReadLine());
    }
    Console.Write("Metropolis population: ");
    for(int i = 2;i<4;i++)
    {
      n[i]= Convert.ToInt32(Console.ReadLine());
    }

    IPlace[]a=new IPlace[2]{
        new Region(s[0],n[0],s[2]),
        new Region(s[1], n[1], s[3])
    };

    foreach(Region c in a){
        Console.WriteLine("Id: "+c.id+"Loc: " + c.loc + "\nSize: " + c.size);
    }
    

  /*  ar.SetValue(n[0],0); //id 1
    ar.SetValue(n[1],1); //id 2
    ar.SetValue(s[0],2); //loc 1
    ar.SetValue(s[1],3); //loc 2
    ar.SetValue(s[2],4); //size 1
    ar.SetValue(s[3],5); //size 2
    ar.SetValue(s[4],7); //nation 1
    ar.SetValue(s[5],8); //nation 2
    ar.SetValue(n[2],9); //population 1
    ar.SetValue(n[3],10); //population 2
*/

    // a.Add(new Region(s[0], n[0], s[2]));
    // a.Add(new Region(s[1], n[1], s[3]));
    // a.Add(new Town(s[0], n[0], s[4]));
    // a.Add(new Town(s[1], n[1], s[5]));
    // a.Add(new Metropolis(s[0], n[0], n[2]));
    // a.Add(new Metropolis(s[1], n[1], n[3]));
     
    /*List<Place> sortpl = a.OrderBy(x=>x.id).ToList();

    Console.WriteLine("\nSort:");
     foreach (Place ar in sortpl)
     {
        ar.Show();
     }
    Console.WriteLine("\n\n:");
    */

}
/*
static void task2()
{
    Console.WriteLine("\nTask2");
    List<Place> b= new List<Place>();

    //b.Add(new Region());
    //b.Add(new Town());
    //b.Add(new Metropolis());

    Console.WriteLine("\nCont():");
     foreach (Place ar in b)
     {
        ar.Show();
     }

    List<Place> c= new List<Place>();
    //c.Add(new Region("small"));
    //c.Add(new Town("usa"));
    //c.Add(new Metropolis(145));

    Console.WriteLine("\nCont(1):");
     foreach (Place ar in c)
     {
        ar.Show();
     }

     

    List<Place> d= new List<Place>();
    //d.Add(new Region());
    //d.Add(new Town());
    //d.Add(new Metropolis());
    d=null;

}

static void task3(){
    Telephone [] t =new Telephone[6]; 
    t[0]=new Persona("Polet","Street1","015 204 37 40");
    t[1]=new Organisation("Company","Street21","754 253 04 42","123 456 7890","Tim");
    t[2]=new Friend("Mola","Street45","145 231 25 64","03.04.2001");

    t[3]=new Persona("Lop","Street025","854 123 45 62");
    t[4]=new Organisation("Brand","Street102","145 785 42 15","485 153 1452","Holy");
    t[5]=new Friend("Wry","Street406","145 245 32 47","12.12.2012");

    foreach (Telephone a in t){
        a.Show();
        Console.WriteLine("Search: "+ a.seach("Lop"));
    }

}
*/
}
public interface IPlace : IComparer<IPlace>{
    public string date();  
    public int date1(); 
}
public class Place : IPlace {

    public string loc;
    public int id;

    int IComparer.Compare(IPlace a, IPlace b){
      Place c1=(Place)a;
      Place c2=(Place)b;
      if (c1.id > c2.id)
         return 1;
      if (c1.id < c2.id)
         return -1;
      else
         return 0;
   }
    public string date() {
        return loc;
    }

    public int date1() {
        return id;
    }

    public Place(string loc, int id) {
        this.loc = loc;
        this.id = id;
    }

    public void Show() {
        Console.Write(id+" Place: "+ loc+"\n");
    }
    
    public Place(){
        this.id=1;
        this.loc="Location";
    }
    public Place(int d){
        this.id=d;
        this.loc="Location";
    }
    public Place(int d, string s){
        this.id=d;
        this.loc=s;
    }

    ~Place(){
        Console.WriteLine("Destructor");
    }
}
public class Region : IPlace {

    public string size;
    public string loc;
    public int id;

    int IComparer.Compare(object a, object b){
        Region r=(Region)a;
        Region r1=(Region)b;
        return String.Compare(r.size,r1.size);
    }

    public Region(string loc, int id, string size) {
        this.size = size;
        this.loc = loc;
        this.id = id;
    }

    public string date() {
        return size;
    }

    public int date1(){
        return id;
    }
    public void Show() {

        Console.Write(id+ " Place "+ loc+" Region " +size+"\n");
    }

    public Region(){
        this.size="big";
    }
    public Region(string s){
        this.size=s;
    }

    ~Region(){
        Console.WriteLine("R Destructor");
    }

}
class Town : IPlace {
    string nation;
    public string loc;
    public int id;

    public Town(string loc, int id, string nation){
        this.nation = nation;
        this.id = id;
        this.loc = loc;
    }
    int IComparer.Compare(object a, object b){
        Town r=(Town)a;
        Town r1=(Town)b;
        return String.Compare(r.nation,r1.nation);
    }
    public string date() {
        return nation;
    }
    public int date1() {
        return id;
    }

    public void Show() {
      Console.Write(id+ " Place "+ loc+" Town " +nation+"\n");
    }

    public Town(){
        this.nation="ukr";
    }
    public Town(string s){
        this.nation=s;
    }

    ~Town(){
        Console.WriteLine("T Destructor");
    }
}
class Metropolis : IPlace {

    int population;
    public string loc;
    public int id;

    int IComparer.Compare(object a, object b){
      Metropolis c1=(Metropolis)a;
      Metropolis c2=(Metropolis)b;
      if (c1.population > c2.population)
         return 1;
      if (c1.population < c2.population)
         return -1;
      else
         return 0;
   }
    public Metropolis(string loc, int id, int population){
        this.population = population;
        this.loc = loc;
        this.id = id;
    }

    public int date1() {
        return population;
    }

    public string date() {
        return loc;
    }

    public void Show() {
        Console.Write(id+ " Place "+ loc+" Metropolis " +population+"\n");
    }

    public Metropolis(){
        this.population=1520;
    }
    public Metropolis(int s){
        this.population=s;
    }

    ~Metropolis(){
        Console.WriteLine("M Destructor");
    }
}

abstract class Telephone{
    abstract public void Show();
    abstract public bool seach(string l);
}

class Persona : Telephone{
    protected string lastname;
    protected string adress;
    protected string phone;

    public Persona(string l, string a,string p){
        this.lastname=l;
        this.adress=a;
        this.phone=p;
    }

    public override void Show()
    {
        Console.WriteLine("\nLastname: "+lastname+"\nAdress: "+adress+"\nPhone: "+phone);
    }

    public override bool seach(string last)
    {
        if(lastname==last){return true;}
        else return false;
    }

    }

class Organisation : Telephone{
    protected string name;
    protected string adress;
    protected string phone;
    protected string fax;
    protected string contact;

    public Organisation(string n, string a,string p,string f,string c){
        this.name=n;
        this.adress=a;
        this.phone=p;
        this.fax=f;
        this.contact=c;
    }

    public override void Show()
    {
        Console.WriteLine("\nName: "+name+"\nAdress: "+adress+"\nPhone: "+phone+"\nFax: "+fax+"\nContact: "+contact);
    }

    public override bool seach(string n)
    {
        if(name==n){return true;}
        else return false;
    }

    }

class Friend : Telephone{
    protected string lastname;
    protected string adress;
    protected string phone;
    protected string date;

    public Friend (string l, string a,string p,string d){
        this.lastname=l;
        this.adress=a;
        this.phone=p;
        this.date=d;
    }

    public override void Show()
    {
        Console.WriteLine("\nLastname: "+lastname+"\nAdress: "+adress+"\nPhone: "+phone+"\nDate: "+date);
    }

    public override bool seach(string last)
    {
        if(lastname==last){return true;}
        else return false;
    }

    }


}