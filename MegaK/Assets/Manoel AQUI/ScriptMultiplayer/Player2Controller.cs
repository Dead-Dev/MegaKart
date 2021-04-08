using UnityEngine;

namespace KartGame.KartSystems {

    public class Player2Controller : BaseInput
    {
        public string Horizontal = "HorizontalP2";
        public string Vertical = "VerticalP2";

        public override Vector2 GenerateInput() {
            return new Vector2 {
                x = Input.GetAxis(Horizontal),
                y = Input.GetAxis(Vertical)
            };
        }
    }
}
