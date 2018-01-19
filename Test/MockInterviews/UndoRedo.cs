using System;
using System.Collections.Generic;

namespace Test.MockInterviews
{
    public class UndoRedo
    {
        private List<char> _result = new List<char>();
        private Stack<int> _undo = new Stack<int>();
        private Stack<int> _redo = new Stack<int>();
        private bool canPerformRedo = false;

        public void Add(char intput, bool canPerformRedo)
        {
            if(!canPerformRedo)
            {
                CleanRedo();
            }
            _result.Add(intput);
            _undo.Push(intput + '0');
            Console.WriteLine(_result);
        }

        
        public void Delete(bool canPerformRedo)
        {
            if (!canPerformRedo)
            {
                CleanRedo();
            }

            if (_result.Count > 0)
            {
                var charToRemove = _result[_result.Count - 1] * -1;
                _undo.Push(charToRemove);
                _result.RemoveAt(_result.Count - 1);
            }
            Console.WriteLine(_result);
        }
        
        public void Undo()
        {
            if (_undo.Count > 0)
            {
                var charactor = _undo.Pop();
                _redo.Push(charactor);

                if(charactor > 0)
                {
                    Delete(true);
                }
                else
                {
                    charactor *= -1;
                    Add((char)charactor, true);
                }
            }
            else
            {
                Console.WriteLine(_result);
            }
        }


        public void Redo()
        {
            if (_redo.Count > 0)
            {
                var charactor = _redo.Pop();
                if(charactor > 0)
                {
                    Add((char)charactor, true);
                } else
                {
                    Delete(true);
                }
            } else {
                Console.WriteLine(_result);
            }
        }

        private void CleanRedo()
        {
            _redo.Clear();
        }
    }
}
