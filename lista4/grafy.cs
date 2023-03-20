using System;
using System.Collections;
using System.Collections.Generic;


class MatrixGraph
{
    int vertex;
    Dictionary <string, int> edge;
    bool[][] matrix;
    public MatrixGraph(int edges, int vertex)
    {
        this.vertex = vertex;
        matrix = new bool[vertex][vertex];
        edge = new Dictionary<string, int>();
    }

    public void addEdge(string parent, string kid)
    {
        matrix
    }
}