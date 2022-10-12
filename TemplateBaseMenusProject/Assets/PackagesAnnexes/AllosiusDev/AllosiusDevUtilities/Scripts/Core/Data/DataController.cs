﻿//
// Updated by Allosius(Yanis Q.) on 7/9/2022.
//

using UnityEngine;

namespace AllosiusDevUtilities.Core
{
    
    namespace Data {

        public class DataController : Singleton<DataController>
        {
            private static readonly string DATA_SCORE = "score";
            private static readonly string DATA_HIGHSCORE = "highscore";
            private static readonly int DEFAULT_INT = 0;

            public bool debug;

#region Properties
            public int Highscore {
                get {
                    return GetInt(DATA_HIGHSCORE);
                }
                private set {
                    SaveInt(DATA_HIGHSCORE, value);
                }
            }

            public int Score {
                get {
                    return GetInt(DATA_SCORE);
                }
                set {
                    // soft clamp value at 0
                    if (value < 0) {
                        value = 0;
                    }
                    
                    SaveInt(DATA_SCORE, value);
                    int _score = this.Score;
                    if (_score > this.Highscore) {
                        this.Highscore = _score;
                    }
                }
            }
#endregion

#region Unity Functions
            
#endregion

#region Private Functions
            private void SaveInt(string _data, int _value) {
                PlayerPrefs.SetInt(_data, _value);
            }

            private int GetInt(string _data) {
                return PlayerPrefs.GetInt(_data, DEFAULT_INT);
            }
#endregion
        }
    }
}