﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AlgorithmsDataStructures;

namespace Algorithms.Tests
{
    public class LinkedListTest
    {
        [Fact]
        public void Remove_ShouldRemoveNode2AndReturnTrue_WhenElementExists()
        {
            var list = new LinkedList();
            List<Node2> nodes = new List<Node2>() { new Node2(1), new Node2(2), new Node2(3), new Node2(4), new Node2(5) };
            foreach(var node in nodes)
            {
                list.AddInTail(node);
            }
            var expectedList = new LinkedList();
            List<Node2> expectedNode2s = new List<Node2>() { new Node2(1), new Node2(2), new Node2(4), new Node2(5) };
            foreach (var node in expectedNode2s)
            {
                expectedList.AddInTail(node);
            }

            var result =  list.Remove(3);

            Assert.True(result);
            Assert.Equivalent(list, expectedList);
        }

        [Fact]
        public void Remove_ShouldNotChangeListAndReturnFalse_WhenElementNotFound()
        {
            var list = new LinkedList();
            List<Node2> nodes = new List<Node2>() { new Node2(1), new Node2(2), new Node2(3), new Node2(4), new Node2(5) };
            foreach (var node in nodes)
            {
                list.AddInTail(node);
            }
            var expectedList = new LinkedList();
            List<Node2> expectedNode2s = new List<Node2>() { new Node2(1), new Node2(2), new Node2(3), new Node2(4), new Node2(5) };
            foreach (var node in expectedNode2s)
            {
                expectedList.AddInTail(node);
            }

            var result = list.Remove(12);
            Assert.False(result);
            Assert.Equivalent(list, expectedList);
        }

        [Fact]
        public void RemoveAll_ShouldRemoveNode2s_WhenElementExists()
        {
            var list = new LinkedList();
            List<Node2> nodes = new List<Node2>() { new Node2(3), new Node2(1), new Node2(2), new Node2(3), new Node2(4), new Node2(5), new Node2(3) };
            foreach (var node in nodes)
            {
                list.AddInTail(node);
            }
            var expectedList = new LinkedList();
            List<Node2> expectedNode2s = new List<Node2>() { new Node2(1), new Node2(2), new Node2(4), new Node2(5) };
            foreach (var node in expectedNode2s)
            {
                expectedList.AddInTail(node);
            }
           
            list.RemoveAll(3);
            Assert.Equivalent(list, expectedList);
        }

        [Fact]
        public void RemoveAll_ShouldNotChangeList_WhenElementNotFound()
        {
            var list = new LinkedList();
            List<Node2> nodes = new List<Node2>() { new Node2(1), new Node2(2), new Node2(4), new Node2(5) };
            foreach (var node in nodes)
            {
                list.AddInTail(node);
            }

            var expectedList = new LinkedList();
            List<Node2> expectedNode2s = new List<Node2>() { new Node2(1), new Node2(2), new Node2(4), new Node2(5) };
            foreach (var node in expectedNode2s)
            {
                expectedList.AddInTail(node);
            }

            list.RemoveAll(16);

            Assert.Equivalent(list, expectedList);
            
        }

        [Fact]
        public void Clear_ShouldClearList_WhenListIsNotEmpty()
        {
            var list = new LinkedList();
            List<Node2> nodes = new List<Node2>() { new Node2(3), new Node2(1), new Node2(2), new Node2(3), new Node2(4), new Node2(5), new Node2(3) };
            foreach (var node in nodes)
            {
                list.AddInTail(node);
            }
            list.Clear();
            var expectedList = new LinkedList();
            Assert.Equivalent(list, expectedList);
        }


        [Fact]
        public void FindAll_ShouldReturnAllMatchingElements_WhenTheyExist()
        {
            var list = new LinkedList();
            List<Node2> nodes = new List<Node2>() { new Node2(3), new Node2(1), new Node2(2), new Node2(3), new Node2(4), new Node2(5), new Node2(3) };
            foreach (var node in nodes)
            {
                list.AddInTail(node);
            }
            var findedNode2sCount = list.FindAll(3).Count;
            var expectedNode2sCount =  3;
            Assert.Equal(expectedNode2sCount, findedNode2sCount);
        }


        [Fact]
        public void FindAll_ShouldReturnEmptyList_WhenElementsNotPresent()
        {
            var list = new LinkedList();
            List<Node2> nodes = new List<Node2>() { new Node2(3), new Node2(1), new Node2(2), new Node2(3), new Node2(4), new Node2(5), new Node2(3) };
            foreach (var node in nodes)
            {
                list.AddInTail(node);
            }
            var findedNode2sCount = list.FindAll(152).Count;
            var expectedNode2sCount = 0;
            Assert.Equal(expectedNode2sCount, findedNode2sCount);
        }


        [Fact]
        public void Count_ShouldReturnZero_WhenElementsNotPresent()
        {
            var list = new LinkedList();

            var nodesCount = list.Count();
            Assert.Equal(0, nodesCount);            
        }


        [Fact]
        public void Count_ShouldReturnFive_WhenFiveElementsExist()
        {
            var list = new LinkedList();
            List<Node2> nodes = new List<Node2>() { new Node2(1), new Node2(2), new Node2(3), new Node2(4), new Node2(5) };
            foreach (var node in nodes)
            {
                list.AddInTail(node);
            }

            var nodesCount = list.Count();

            Assert.Equal(5, nodesCount);
        }

        [Fact]
        public void InsertAfter_ShouldInsertElement_WhenTargetElementFound()
        {
            var list = new LinkedList();
            List<Node2> nodes = new List<Node2>() { new Node2(1), new Node2(2), new Node2(3), new Node2(4), new Node2(5) };
            foreach (var node in nodes)
            {
                list.AddInTail(node);
            }
            
            var expectedList = new LinkedList();
            var nodeToInsert = new Node2(12);
            List<Node2> expectedNode2s = new List<Node2>() { new Node2(1), new Node2(2), nodeToInsert, new Node2(3), new Node2(4), new Node2(5) };
            foreach (var node in expectedNode2s)
            {
                expectedList.AddInTail(node);
            }

            var nodeAfter = nodes[1];
            list.InsertAfter(nodeAfter,nodeToInsert);


            Assert.Equivalent(list, expectedList);
        }


        [Fact]
        public void InsertAfter_ShouldNotChangeList_WhenElementNotFound()
        {
            var list = new LinkedList();
            List<Node2> nodes = new List<Node2>() { new Node2(1), new Node2(2), new Node2(3), new Node2(4), new Node2(5) };
            foreach (var node in nodes)
            {
                list.AddInTail(node);
            }

            var expectedList = new LinkedList();
            List<Node2> expectedNode2s = new List<Node2>() { new Node2(1), new Node2(2), new Node2(3), new Node2(4), new Node2(5) };
            foreach (var node in expectedNode2s)
            {
                expectedList.AddInTail(node);
            }

            var nodeAfter = new Node2(16);
            var nodeToInsert = new Node2(12);

            list.InsertAfter(nodeAfter, nodeToInsert);

            Assert.Equivalent(list, expectedList);
        }
    }
}
