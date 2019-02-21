using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.BattleShip
{
    public class Map
    {
        int n_of_rows;
        int n_of_columns;
        enum cell { Free, Wounded, Killed, Exception};
        int[][] matrix;
        
        public Map()
        {
            n_of_rows = n_of_columns = 10;
            InitializeMap();
        }

        public Map(int n_of_rows, int n_of_columns)
        {
            try
            {
                this.n_of_rows = n_of_rows;
                this.n_of_columns = n_of_columns;
            }
            catch (Exception e)
            {
                n_of_rows = n_of_columns = 10;
            }
            finally
            {
                InitializeMap();
            }
        }

        private void InitializeMap()
        {
            matrix = new int[n_of_rows][];
            for (int i = 0; i < n_of_rows; matrix[i++] = new int[n_of_columns]) ;
            for (int i = 0; i < n_of_rows; i++)
            {
                for (int j = 0; j < n_of_columns; j++)
                {
                    matrix[i][j] = (int)cell.Free;
                }
            }
        }

        public int getCellState(coord<int> pos)
        {
            int ans;
            try
            {
                ans = matrix[pos.getX()][pos.getY()];
            }
            catch(Exception e)
            {
                ans = (int)cell.Exception;
            }
            return ans;
        }

        public void changeState(coord<int> pos, int state)
        {
            if (state >= (int)cell.Free && state < (int)cell.Exception)
            {
                matrix[pos.getX()][pos.getY()] = state;
            }
        }
    }

    public class coord<T>
    {
        private T x; // row
        private T y; // column
        
        public coord(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public T getX()
        {
            return x;
        }

        public T getY()
        {
            return y;
        }
    }
}
