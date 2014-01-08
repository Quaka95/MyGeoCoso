using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Mate.Graph;
using info.lundin.math;

namespace MyGeoCoso
{
    public partial class FormBase
    {
    }

    public class BisezioneParametr
    {
    }
}

/*////////////////////////////////////////////////////////////////////////////
//      Questo commento contiene la riflessione per le secanti              //
//                                                                          //
//                                                                          //
//      Data una retta, se sappiamo che r: y=xm+q                           //
//      allora:                                                             //
//                                                                          //
//          0 = xm+q    quindi x = -q/m                                     //
//                                                                          //
//      Se partiamo dalla formula della retta passante per 2 punti          //
//                                                                          //
//                                                                          //
//      Y-Y1       X-X1                                                     //
//     ------  _  ------                                                    //
//      X2-X1      X2-X1                                                    //
//                                                                          //
//                                                                          //
//      Allora arriviamo a                                                  //
//                                                                          //
//                                                                          //
//              X1(y2-y1)                                                   //
//             ----------  -Y1                                              //
//              X2-X1                                                       //
//      X=-----------------------                                           //
//                 Y2-Y1                                                    //
//                -------                                                   //
//                 X2-x1                                                    //
//                                                                          //
////////////////////////////////////////////////////////////////////////////*/
