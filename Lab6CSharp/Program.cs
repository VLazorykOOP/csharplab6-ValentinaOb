using System;
using System.Collections;
using System.Collections.Generic;

namespace Pr{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("\nLab 6");
      
      Console.WriteLine("Choose task: ");
      int s = Convert.ToInt32(Console.ReadLine());

  switch(s){
    case 1: { task1();  break;}
    case 2: { task2();  break;}
  }
      
    }

static void task1()
{
    Console.WriteLine("\nTask2");
    List<Place> a= new List<Place>();

    int [] n=new int[4];
    string [] s=new string[6];

    for(int i = 0;i<2;i++)
    {
        Console.Write("Place id "+(i+1)+" : ");
      n[i]= Convert.ToInt32(Console.ReadLine());
    }

    for(int i = 0;i<2;i++)
    {
        Console.Write("\nPlace location "+(i+1)+" : ");
      s[i]= Convert.ToString(Console.ReadLine());
    }

    for(int i = 2;i<4;i++)
    {
        Console.Write("\nRegion size(big/medium/small) "+(i-1)+" : ");
      s[i]= Convert.ToString(Console.ReadLine());
    }

    for(int i = 4;i<6;i++)
    {
        Console.Write("\nTown nation(ukr/usa/uk) "+(i-3)+" : ");
      s[i]= Convert.ToString(Console.ReadLine());
    }
    
    for(int i = 2;i<4;i++)
    {
        Console.Write("\nMetropolis population "+(i-1)+" : ");
      n[i]= Convert.ToInt32(Console.ReadLine());
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

     a.Add(new Region(s[0], n[0], s[2]));
     a.Add(new Region(s[1], n[1], s[3]));
     a.Add(new Town(s[0], n[0], s[4]));
     a.Add(new Town(s[1], n[1], s[5]));
     a.Add(new Metropolis(s[0], n[0], n[2]));
     a.Add(new Metropolis(s[1], n[1], n[3]));
     
    List<Place> sortpl = a.OrderBy(x=>x.id).ToList();


    var r1 =new Region(s[0], n[0], s[2]);
    var r2 =new Region(s[1], n[1], s[3]);
  
    Region[] r = { r1, r2};
    Array.Sort(r);
  
    Console.WriteLine("\nRegion: ");
    foreach (Region p in r){
    Console.WriteLine(p.id + "\t\t" + p.size);
    }

    Town[] t = { new Town(s[0], n[0], s[4]), new Town(s[1], n[1], s[5])};
    Array.Sort(t);
    
    Console.WriteLine("\nTown: ");
    foreach (Town p in t){
    Console.WriteLine(p.id + "\t\t" + p.nation);
    }

    Metropolis[] m = { new Metropolis(s[0], n[0], n[2]), new Metropolis(s[1], n[1], n[3])};
    Array.Sort(m);
  
    Console.WriteLine("\nMetropolis: ");
    foreach (Metropolis p in m){
    Console.WriteLine(p.id + "\t\t" + p.population);
    }


    Town tn =new Town(s[0], n[0], s[4]);
    Town z = (Town)tn.Clone();
    Console.WriteLine("\nTowm: ");
    tn.Show();
    Console.WriteLine("\nClone Town: ");
    z.Show();
    Console.WriteLine("\n");

    /*
    Console.WriteLine("\nSort:");
     foreach (Place ar in sortpl)
     {
        ar.Show();
     }
    Console.WriteLine("\n\n:");

    List<Place> b= new List<Place>();

    b.Add(new Region());
    b.Add(new Town());
    b.Add(new Metropolis());

    Console.WriteLine("\nCont:");
     foreach (Place ar in b)
     {
        ar.Show();
     }
*/

}

static void task2(){
    Telephone [] t =new Telephone[6]; 
    t[0]=new Persona("Polet","Street1","015 204 37 40");
    t[1]=new Organisation("Company","Street21","754 253 04 42","123 456 7890","Tim");
    t[2]=new Friend("Mola","Street45","145 231 25 64","03.04.2001");

    t[3]=new Persona("Lop","Street025","854 123 45 62");
    t[4]=new Organisation("Brand","Street102","145 785 42 15","485 153 1452","Holy");
    t[5]=new Friend("Wry","Street406","145 245 32 47","12.12.2012");

    Persona[] p = { new Persona("Polet","Street1","015 204 37 40"),new Persona("Lop","Street025","854 123 45 62")};
    Array.Sort(p);
    
    Console.WriteLine("\nPersona: ");
    foreach (Persona k in p){
    Console.WriteLine(k.phone + "\t\t" + k.lastname);
    }

    Organisation[] o= { new Organisation("Company","Street21","754 253 04 42","123 456 7890","Tim"), new Organisation("Brand","Street102","145 785 42 15","485 153 1452","Holy")};
    Array.Sort(o);
  
    Console.WriteLine("\nOrganisation: ");
    foreach (Organisation k in o){
    Console.WriteLine(k.phone + "\t\t" + k.name);
    }

    Friend[] f = { new Friend("Mola","Street45","145 231 25 64","03.04.2001"),new Friend("Wry","Street406","145 245 32 47","12.12.2012")};
    Array.Sort(f);
    
    Console.WriteLine("\nFriend: ");
    foreach (Friend k in f){
    Console.WriteLine(k.phone + "\t\t" + k.date);
    }
    
    /*
    foreach (Telephone a in t){
        a.Show();
        Console.WriteLine("Search: "+ a.seach("Lop"));
    }
    */

}

}
public class Place:IComparable, ICloneable {

    public string loc;
    public int id;
    public int CompareTo(object? o)
    {
        if(o is Place p) return id.CompareTo(p.id);
        else throw new ArgumentException("Error");
    }
    public object Clone(){
        return new Place(loc,id);
    }

    public string Location() {
        return loc;
    }

    public int id_doc() {
        return id;
    }

    public Place(string loc, int id) {
        this.loc = loc;
        this.id = id;
    }

    public virtual void Show() {
        Console.Write(id+" Place: "+ loc+"\n");
    }
    
    public Place(){
        id=1;
        loc="Location";
    }
    public Place(int d){
        id=d;
        loc="Location";
    }
    public Place(int d, string s){
        id=d;
        loc=s;
    }

    ~Place(){
        Console.WriteLine("Destructor");
    }
}
class Region : Place {

    public string size;

    public int CompareTo(object? o)
    {
        if(o is Region p) return size.CompareTo(p.size);
        else throw new ArgumentException("Error");
    }
    public Region(string loc, int id, string size) : base(loc,id) {
        this.size = size;
    }
    public object Clone(){
        return new Region(size);
    }

    public string getSize() {
        return size;
    }

    public override void Show() {

        Console.Write(id+ " Place "+ loc+" Region " +size+"\n");
    }

    public Region(){
        size="big";
    }
    public Region(string s){
        size=s;
    }

    ~Region(){
        Console.WriteLine("R Destructor");
    }

}
class Town : Place {
    public string nation;
    public int CompareTo(object? o)
    {
        if(o is Town p) return nation.CompareTo(p.nation);
        else throw new ArgumentException("Error");
    }
    public object Clone(){
        return new Town(nation);
    }
    public Town(string loc, int id, string nation) : base(loc,id){
        this.nation = nation;
    }

    public string getNation() {
        return nation;
    }

    public override void Show() {
      Console.Write(id+ " Place "+ loc+" Town " +nation+"\n");
    }

    public Town(){
        nation="ukr";
    }
    public Town(string s){
        nation=s;
    }

    ~Town(){
        Console.WriteLine("T Destructor");
    }
}
class Metropolis : Place {

    public int population;

    public int CompareTo(object? o)
    {
        if(o is Metropolis p) return population.CompareTo(p.population);
        else throw new ArgumentException("Error");
    }
    public object Clone(){
        return new Metropolis(population);
    }
    public Metropolis(string loc, int id, int population) : base(loc,id){
        this.population = population;
    }

    public int getPopulation() {
        return population;
    }

    public override void Show() {
        Console.Write(id+ " Place "+ loc+" Metropolis " +population+"\n");
    }

    public Metropolis(){
        population=1520;
    }
    public Metropolis(int s){
        population=s;
    }

    ~Metropolis(){
        Console.WriteLine("M Destructor");
    }
}

abstract class Telephone:IComparable{
    abstract public void Show();
    abstract public bool seach(string l);
    public int CompareTo(object? o){
        return 0;
    }

}

class Persona : Telephone{
    public string lastname;
    public string adress;
    public string phone;

    public Persona(string l, string a,string p){
        this.lastname=l;
        this.adress=a;
        this.phone=p;
    }
    public int CompareTo(object? o)
    {
        if(o is Persona p) return lastname.CompareTo(p.lastname);
        else throw new ArgumentException("Error");
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
    public string name;
    public string adress;
    public string phone;
    public string fax;
    public string contact;

    public Organisation(string n, string a,string p,string f,string c){
        this.name=n;
        this.adress=a;
        this.phone=p;
        this.fax=f;
        this.contact=c;
    }
    public int CompareTo(object? o)
    {
        if(o is Organisation p) return name.CompareTo(p.name);
        else throw new ArgumentException("Error");
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
    public string lastname;
    public string adress;
    public string phone;
    public string date;

    public Friend (string l, string a,string p,string d){
        this.lastname=l;
        this.adress=a;
        this.phone=p;
        this.date=d;
    }
    public int CompareTo(object? o)
    {
        if(o is Friend p) return date.CompareTo(p.date);
        else throw new ArgumentException("Error");
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