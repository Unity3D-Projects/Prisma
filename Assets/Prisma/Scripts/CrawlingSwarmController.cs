using UnityEngine;

namespace Prisma
{
    public class CrawlingSwarmController : MonoBehaviour
    {
        [SerializeField] Swarm.CrawlingSwarm[] _swarms;

        public float throttle {
            set { _throttle = value; }
        }

        float _throttle;

        void LateUpdate()
        {
            if (_throttle < 0.01f)
            {
                foreach (var s in _swarms) s.enabled = false;
            }
            else
            {
                foreach (var s in _swarms)
                {
                    s.enabled = true;
                    s.trim = _throttle;
                }
            }
        }
    }
}
