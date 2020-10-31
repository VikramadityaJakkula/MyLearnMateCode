using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Kit3D.Windows.Media.Media3D;
using Kit3D.Windows.Controls;
using System.Windows.Media.Imaging;
using Kit3D.Windows.Media;

namespace iCLASS
{
    public partial class SpinningGlobe :UserControl
    {
        private const double IMAGE_WIDTH = 421;    // Image Width
        private const double IMAGE_HEIGHT = 280;   // Image Height
        private const int MAX_FRAME_RATE = 40;      // Frame rate
        private const double VIEW_DIMENSION = 4;    // view dimension
        private const int SPIN_SPEED = 5;           // Angle increment
        private const int ANGLE_INC = 2;           // Angle increment
        private const double FIEW_OF_VIWE = 60;        // Fied of view
        private const double ALPHA = 0.7;          // plane alpha

        private Viewport3D _viewport;            // 3D Object Container
        private PerspectiveCamera _camera;         // view camera
        private ModelVisual3D _globe;
        private int _angle;                         // Camera Rotate Angle
        private int _spinAngle;                     // Spin angle
        public SpinningGlobe()
        {
            InitializeComponent();
            App.Current.Host.Settings.MaxFrameRate = MAX_FRAME_RATE;

            // create Scene
            createScene();
        }

        void CompositionTarget_Rendering(object sender, EventArgs e)
        {

            // Create the transform
            Transform3DGroup tg = new Transform3DGroup();
            tg.Children.Add(new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0, 1, 0), _spinAngle), new Point3D(0, 0, 0)));
            _globe.Transform = tg;


            // transform the camera
            double radian = _angle * Math.PI / 180;
            _camera.Position = new Point3D(Math.Sin(radian) * VIEW_DIMENSION, Math.Sin(radian) * VIEW_DIMENSION * 1.2, Math.Cos(radian) * VIEW_DIMENSION);
            _camera.LookDirection = new Vector3D(-_camera.Position.X, -_camera.Position.Y, -_camera.Position.Z);

            // increase the angle
            _angle = (_angle + ANGLE_INC) % 360;
            _spinAngle = (_spinAngle + SPIN_SPEED) % 360;
        }

        /////////////////////////////////////////////////////        
        // Private Methods
        /////////////////////////////////////////////////////	

        // breakdown the image into texture plane
        private void createScene()
        {
            // Create the camera.
            _camera = new PerspectiveCamera(new Point3D(0, 0, VIEW_DIMENSION), new Vector3D(0, 0, -1), new Vector3D(0, 1, 0), FIEW_OF_VIWE);

            // Create Viewport3D as content of window.
            _viewport = new Viewport3D();
            _viewport.Camera = _camera;

            // create the texture plane with image
            _globe = createGlobe("/iCLASS;component/world_map.png");
            _viewport.Children.Add(_globe);

            // add view port to the stage
            LayoutRoot.Children.Add(_viewport);
        }

        // create a new texture mapped plane
        private ModelVisual3D createGlobe(string imagePath)
        {
            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = new BitmapImage(new Uri(imagePath, UriKind.Relative));

            MeshGeometry3D mesh = GenerateSphere(new Point3D(0, 0, 0), 1, 16, 8);

            GeometryModel3D model = new GeometryModel3D();
            model.Geometry = mesh;
            model.Material = new DiffuseMaterial(new Kit3DBrush(imageBrush, (int)IMAGE_WIDTH, (int)IMAGE_HEIGHT));
            // model.SeamSmoothing = 1;
            model.BackMaterial = model.Material;

            // create the model based on the material and transform
            ModelVisual3D modvis = new ModelVisual3D();
            //modvis.Transform = tg;
            modvis.Content = model;
            modvis.Opacity = ALPHA;

            return modvis;
        }

        MeshGeometry3D GenerateSphere(Point3D center, double radius, int slices, int stacks)
        {
            // Create the MeshGeometry3D.
            MeshGeometry3D mesh = new MeshGeometry3D();

            // Fill the Position, Normals, and TextureCoordinates collections.
            for (int stack = 0; stack <= stacks; stack++)
            {
                double phi = Math.PI / 2 - stack * Math.PI / stacks;
                double y = radius * Math.Sin(phi);
                double scale = -radius * Math.Cos(phi);

                for (int slice = 0; slice <= slices; slice++)
                {
                    double theta = slice * 2 * Math.PI / slices;
                    double x = scale * Math.Sin(theta);
                    double z = scale * Math.Cos(theta);

                    Vector3D normal = new Vector3D(x, y, z);
                    //mesh.Normals.Add(normal);
                    mesh.Positions.Add(normal + center);
                    mesh.TextureCoordinates.Add(
                            new Point((double)slice / slices,
                                      (double)stack / stacks));
                }
            }

            // Fill the TriangleIndices collection.
            for (int stack = 0; stack < stacks; stack++)
            {
                for (int slice = 0; slice < slices; slice++)
                {
                    int n = slices + 1; // Keep the line length down.

                    if (stack != 0)
                    {
                        mesh.TriangleIndices.Add((stack + 0) * n + slice);
                        mesh.TriangleIndices.Add((stack + 1) * n + slice);
                        mesh.TriangleIndices.Add((stack + 0) * n + slice + 1);
                    }
                    if (stack != stacks - 1)
                    {
                        mesh.TriangleIndices.Add((stack + 0) * n + slice + 1);
                        mesh.TriangleIndices.Add((stack + 1) * n + slice);
                        mesh.TriangleIndices.Add((stack + 1) * n + slice + 1);
                    }
                }
            }
            return mesh;
        }

        /////////////////////////////////////////////////////        
        // Handlers
        /////////////////////////////////////////////////////	

        // add the rendering handler
        public void Start()
        {
            Kit3D.Windows.Media.CompositionTarget.Rendering += new EventHandler(CompositionTarget_Rendering);
        }
    
     private void button4_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new sci3());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass3()); 
        }

        private void mathmain_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

    }
    
    
    }

