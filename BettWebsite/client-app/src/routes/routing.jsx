import LALIGA from '../views/starter/starter.jsx';
// ui components
import PremierLeague from '../views/ui-components/PremiereLeague.tsx';
import SerieA from '../views/ui-components/SerieA.tsx';
import Liga1 from '../views/ui-components/Liga1.tsx';
import Bundesliga from '../views/ui-components/Bundesliga.tsx';

var ThemeRoutes = [
  { 
    path: '/LaLiga', 
    name: 'LaLiga', 
    icon: 'mdi mdi-arrange-send-backward', 
    component: LALIGA 
  },
  {
    path: '/PremierLeague',
    name: 'PremierLeague',
    icon: 'mdi mdi-arrange-send-backward',
    component: PremierLeague
  },
  {
    path: '/SerieA',
    name: 'SerieA',
    icon: 'mdi mdi-arrange-send-backward',
    component: SerieA
  },
  {
    path: '/Liga1',
    name: 'Liga1',
    icon: 'mdi mdi-arrange-send-backward',
    component: Liga1
  },
  {
    path: '/Bundesliga',
    name: 'Bundesliga',
    icon: 'mdi mdi-arrange-send-backward',
    component: Bundesliga
  },
  { path: '/', pathTo: '/LaLiga', name: 'LALIGA', redirect: true }
];
export default ThemeRoutes;
