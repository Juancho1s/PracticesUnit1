﻿using trees_123_;

internal class MainClass
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, buddies");

        Node firstNode = new Node(1);
        Node secondNode = new Node(2);
        Node thirdNode = new Node(3);
        Node fourthNode = new Node(4);
        Node fifthNode = new Node(5);
        Node sixthhNode = new Node(6);
        Node seventhNode = new Node(7);
        Node eightNode = new Node(8);
        Node ninthNode = new Node(9);
        Node thenthNode = new Node(10);
        Node eleventhNode = new Node(11);


        firstNode.addNode(secondNode);
        firstNode.addNode(thirdNode);
        firstNode.addNode(fourthNode);
        firstNode.addNode(fifthNode);
        firstNode.addNode(sixthhNode);
        firstNode.addNode(seventhNode);
        firstNode.addNode(eightNode);
        firstNode.addNode(ninthNode);
        firstNode.addNode(thenthNode);
        firstNode.addNode(eleventhNode);
    }
}