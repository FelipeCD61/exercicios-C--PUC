using System;

class Produto{
    private int id;
    private string name;
    private double price;
    private int amount;

    public Produto(int id){
        this.id = id;
    }

    public int GetID(){
        return id;
    }
    public void SetID(int id){
        this.id = id;
    }

    public string GetName(){
        return name;
    }
    public void SetName(string name){
        this.name = name;
    }

    public double GetPrice(){
        return price;
    }
    public void SetPrice(double price){
        this.price = price;
    }

    public int GetAmount(){
        return amount;
    }
    public void SetAmount(int amount){
        this.amount = amount;
    }
}