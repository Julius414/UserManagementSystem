import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import Edit from './components/Edit';

import './custom.css'
import Users from './components/Users';

export default () => (
    <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/users/:startDateIndex?' component={Users} />
        <Route path='/edit' component={Edit} />
    </Layout>
);
