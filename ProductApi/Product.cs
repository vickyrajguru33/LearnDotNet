using System;

public class Product {
    public int id {get; set;}
    public String name{get; set;}
    public double price{get; set;}

    public Product(int id, String name, double price){
        this.id = id;
        this.name = name;
        this.price = price;
    }
}