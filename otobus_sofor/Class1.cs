using System;
using System.Collections.Generic;
using System.Text;

namespace otobus_sofor
{

	public class Node
	{
		public string data;
		public Node next;
		public Node(string d)
		{
			data = d;
			next = null;
		}
	}

	public class LinkedList
	{
		public Node head;

		public void push(string new_data)
		{
			
			Node new_node = new Node(new_data);

			
			new_node.next = head;

			
			head = new_node;
		}

		public bool search(Node head, string x)
		{
			

	

			if (head == null)
				return false;

		
			if (head.data == x)
				return true;

		
			return search(head.next, x);
		}

		
	}



}
